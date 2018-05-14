/*
	Using Vin Number 35248256915328751
	Test pickup date:	To cause pickup overlap, 21/05/2018 - 26/05/2018
						To cause return overlap, 19/05/2018 - 22/05/2018						
						Clear date to use 30/05/2018 - 12/05/2018	
						
						vin = '35248256915328751' and 					
*/

select *
from dbo.Bookings
where 
(pickupDate between convert(date, '2018-05-07', 111) and convert(date, '2018-05-13', 111))

/*(returnDate between convert(date, 19/05/2018) and convert(date, 27/05/2018)) or 
(pickupDate between convert(date, 30/05/2018) and convert(date, 12/05/2018)); */