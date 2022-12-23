
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE add_Sellers
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	CREATE TABLE  #CSV_sellers(
		sellers_id INT PRIMARY KEY,
		sellers_name VARCHAR(50),
		sellers_surname NVARCHAR(50),
	);

	BULK INSERT  #CSV_sellers
	FROM 'J:\DB\CDB\names.csv'
	WITH(
		FIELDTERMINATOR = ';',
		ROWTERMINATOR ='\n',
		FIRSTROW = 2
	);

	DECLARE @sellers_amount BIGINT;
	SET @sellers_amount = 10;

	WHILE @sellers_amount > 0
		BEGIN
			DECLARE @sellers_name NVARCHAR(50);
			DECLARE @sellers_surname NVARCHAR(50);
			SELECT TOP 1 @sellers_name = sellers_name, @sellers_surname = sellers_surname FROM #CSV_sellers ORDER BY NEWID();
			
			INSERT INTO Sellers(name, surname) VALUES(@sellers_name, @sellers_surname);
			SET @sellers_amount -= 1;
		END
	DROP TABLE #CSV_sellers;
END
GO