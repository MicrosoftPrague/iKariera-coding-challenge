/****
**  John and Mary want to travel between a few towns A, B, C ...
**  Mary has on a sheet of paper a list of distances between these towns.
**  'distances' = [50, 55, 57, 58, 60]. John is tired of driving and he says to Mary
**  that he doesn't want to drive more than 'maxDistance' = 174 miles and he will visit only 3 towns.
**
**  Which distances, hence which towns, they will choose so that the sum of the
**  distances is the biggest possible to please Mary - but less than 'maxDistance' - to please John- ?
**
**  Example:
**  With list 'distances' and 3 towns to visit they can make a choice between:
**  [50,55,57], [50,55,58], [50,55,60], [50,57,58], [50,57,60], [50,58,60],
**  [55,57,58], [55,57,60], [55,58,60], [57,58,60].
**
**  The sums of distances are then: 162, 163, 165, 165, 167, 168, 170, 172, 173, 175.
**
**  The biggest possible sum taking a limit of 174 into account is then 173 and the
**  distances of the 3 corresponding towns is [55, 58, 60].
**
**  The function chooseBestSum will take as parameters:
**      - 'maxDistance' (maximum sum of distances, integer >= 0)
**      - 'numberOfTowns' (number of towns to visit, integer >= 1)
**      - 'distances' (list of distances, all distances 
**         are positive or null integers and this list has at least one element)
**
**  The function returns the "best" sum ie the biggest possible sum of k distances
**  less than or equal to the given limit 'maxDistance', if that sum exists, or otherwise null.
**
**  Examples:
**  distances = [50, 55, 56, 57, 58] choose_best_sum(163, 3, distances) -> 163
**  distances = [50] choose_best_sum(163, 3, distances) -> null
**  distances = [91, 74, 73, 85, 73, 81, 87] choose_best_sum(230, 3, distances) -> 228
**
**  https://en.wikipedia.org/wiki/Subset_sum_problem
****/

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class BestTravel
    {
        public static int? chooseBestSum(int maxDistance, int numberOfTowns, List<int> distances)
        {
            // TODO Add implementation
            return null;
        }
    }
}
