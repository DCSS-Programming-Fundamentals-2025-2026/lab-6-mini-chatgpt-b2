using System;

namespace Lib.Batching.Sampling
{
    public static class BatchWindowSampler
    {
        public static int GetRandomStartIndex(int totalTokens, int blockSize, Random rng)
        {
            if (totalTokens <= 1)
            {
                throw new InvalidOperationException("Недостатньо токенів для формування батчу.");
            }
            if (rng == null)
            {
                throw new ArgumentNullException(nameof(rng), "Random generator cannot be null.");
            }
            if (blockSize <= 0)
            {
                throw new ArgumentException("BlockSize must be positive.", nameof(blockSize));
            }
            if (totalTokens <= blockSize)
            {
                return 0;
            }
            int maxStartIndex = totalTokens - blockSize;
            return rng.Next(0, maxStartIndex);
        }
    }
}