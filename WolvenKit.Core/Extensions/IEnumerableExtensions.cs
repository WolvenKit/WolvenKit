using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolvenKit.Core.Extensions;

public static class IEnumerableExtensions
{
    public static Task ParallelForEachAsync<T>(this IEnumerable<T> source, Func<T, Task> funcBody, int maxDoP = 4)
    {
        async Task AwaitPartition(IEnumerator<T> partition)
        {
            using (partition)
            {
                while (partition.MoveNext())
                {
                    await Task.Yield();
                    await funcBody(partition.Current)
                        .ConfigureAwait(false);
                }
            }
        }

        return Task.WhenAll(
            Partitioner
                .Create(source)
                .GetPartitions(maxDoP)
                .AsParallel()
                .Select(AwaitPartition));
    }

    public static Task ParallelForEachAsync<T1, T2>(this IEnumerable<T1> source, Func<T1, T2, Task> funcBody, T2 secondInput, int maxDoP = 4)
    {
        async Task AwaitPartition(IEnumerator<T1> partition)
        {
            using (partition)
            {
                while (partition.MoveNext())
                {
                    await Task.Yield();
                    await funcBody(partition.Current, secondInput).ConfigureAwait(false);
                }
            }
        }

        return Task.WhenAll(
            Partitioner
                .Create(source)
                .GetPartitions(maxDoP)
                .AsParallel()
                .Select(AwaitPartition));
    }

    public static Task ParallelForEachAsync<T1, T2, T3>(this IEnumerable<T1> source, Func<T1, T2, T3, Task> funcBody, T2 secondInput, T3 thirdInput, int maxDoP = 4)
    {
        async Task AwaitPartition(IEnumerator<T1> partition)
        {
            using (partition)
            {
                while (partition.MoveNext())
                {
                    await Task.Yield();
                    await funcBody(partition.Current, secondInput, thirdInput).ConfigureAwait(false);
                }
            }
        }

        return Task.WhenAll(
            Partitioner
                .Create(source)
                .GetPartitions(maxDoP)
                .AsParallel()
                .Select(AwaitPartition));
    }
}
