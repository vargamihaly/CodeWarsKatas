# CodeWarsKatas

#### CreatePhoneNumber

> Your task is to make function, which returns the sum of a sequence of integers.
> The sequence is defined by 3 non-negative values: begin, end, step.
> If begin value is greater than the end, function should returns 0
        
    Examples

    SequenceSum(2,2,2); // => 2
    SequenceSum(2, 6, 2); // => 12 -> 2 + 4 + 6
    SequenceSum(1, 5, 1); // => 15 -> 1 + 2 + 3 + 4 + 5
    SequenceSum(1, 5, 3); // => 5 -> 1 + 4
    
    
#### NumberOfPeopleInTheBus

> There is a bus moving in the city, and it takes and drop some people in each bus stop.
> You are provided with a list(or array) of integer arrays(or tuples). Each integer array has two items which represent number of people get into bus(The first item) and number of > people get off the bus(The second item) in a bus stop.
> Your task is to return number of people who are still in the bus after the last bus station(after the last array). Even though it is the last bus stop, the bus is not empty and > some people are still in the bus, and they are probably sleeping there :D
> Take a look on the test cases.
> Please keep in mind that the test cases ensure that the number of people in the bus is always >= 0. So the return integer can't be negative.
> The second value in the first integer array is 0, since the bus is empty in the first bus stop.

