-- SQL JOB Creation in MS SQL Server Management Studio
-- Step 1: Make sure SQL Server Agent is up and running (right click on it and click Start if not yet started)
-- Step 2: prepare some SQL queries which are to be run in job
-- Step 3: Go for job creation
	-- Right click on Jobs (under SQL Server agent)
	-- select New job
	-- provide some name and description about the job
	-- go to steps, click new provide Step name and Type (for SQL queries select T-SQL), select database,and fill the command with the query
	-- go to schedules and add schedule as required by providing name and type
	-- click ok, you will see a new job which was created with the name you provided under jobs
-- Step 4: To run the job manually (for testing) click on the job which was created, and click on Start job at step
-- Step 5: For deleting a job, right click on the job name and click on delete and then ok. 

-- sample Queries
select * from Addresses -- for checking records in the table (assuming its created)

-- some sample queries to perform delete and update
delete from Addresses where id = 10
Go
update Addresses set city = 'Mumbai'
where id = 1
Go