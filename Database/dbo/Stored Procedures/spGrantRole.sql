﻿
            --
            -- Version 2008
            -- Author R. Myers
            -- Create version for sql 
            -- Version 2.3
            -- v2.1 allow adding owner of proc, udf, ...
            -- v2.2 change if to select vs execute
            -- v2.3 added a call to spGrantManual
            -- v2.3 Any addition security added to a database that can not be automated will be added here. 
            -- v2.3 Proc will only be called from spgrantrole if it exists. - revokes or unique security constraints
            -- v2.4 BAM - Updated the proc so that it pulls the schema name instead of the user name. Updated the grant statements as well
            CREATE PROCEDURE [dbo].[spGrantRole] (@dbug      int = 0)
            as
                    if not exists(select * from sysusers where name = 'db_spexec')
                        EXEC sp_addrole N'db_spexec'

            declare
                @cmd    varchar(1000), 
                @spname sysname,
                @type   varchar(5),
                @usr    sysname,
                -- v2.4
                @schema nvarchar(50)

            --set @dbug = 0

            -- v2.1
            declare objcur cursor for
            --v2.4
            select
                o.name,
                o.type,
                u.name,
                s.name as schemaname
            from   sysobjects o,
                sysusers u,
                sys.objects j,
                sys.schemas s 
            where (o.type = 'p' 
                or  o.type = 'FN'
                or  o.type = 'TF' 
                or  o.type = 'IF')
                and  o.name not like 'dt_%'
                and o.uid = u.uid
                and o.name = j.name
                and j.schema_id = s.schema_id
            open objcur 
            -- v2.2 
            fetch next from objcur into @spname, @type , @usr, @schema
            while @@fetch_status = 0 
            begin
            -- v2.1
                if @type = 'TF' or @type = 'IF' 
            -- v2.2 
                -- v2.4
                    select @cmd = 'GRANT SELECT on [' + @schema + '].[' + @spname + '] to db_spexec'
                ELSE
                -- v2.4
                    select @cmd = 'GRANT execute on [' + @schema + '].[' + @spname + '] to db_spexec'
                if @dbug = 0
                    exec (@cmd)     
                else
                    print @cmd
                -- v2.4
                select @cmd = 'GRANT view definition on [' + @schema + '].[' + @spname + '] to db_spexec'
                exec (@cmd)
            -- v2.1
                fetch next from objcur into @spname, @type , @usr, @schema
            end
            close objcur 
            deallocate objcur


            --- v2.3
            --if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spGrantAdditional]')and OBJECTPROPERTY(id, N'isprocedure') = 1)
                --exec dbo.spGrantAdditional

            --- v2.3
            --if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spGrantManual]')and OBJECTPROPERTY(id, N'isprocedure') = 1)
                --exec dbo.spGrantManual

