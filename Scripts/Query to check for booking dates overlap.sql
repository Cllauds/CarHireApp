/*
	Using Vin Number 35248256915328751
	Test pickup date:	To cause return overlap, 19/05/2018 - 22/04/2018
						To cause pickup overlap, 24/05/2018 - 29/05/2018
						Clear date to use 30/05/2018 - 12/05/2018						
*/

select *
from dbo.Bookings
where vin = '35248256915328751'
and ;