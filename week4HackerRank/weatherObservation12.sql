SELECT Distinct city 
FROM station 
where city regexp '^[^aeiou].*[^aeiou]$'