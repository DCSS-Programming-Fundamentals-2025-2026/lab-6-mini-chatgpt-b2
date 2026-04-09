namespace Lib.Training.Configuration
{
    public class TrainingConfig
    {
        private int _epochs = 10;
        private int _stepsPerEpoch = 100;
        private float _learningRate = 0.001f;
        private int _batchSize = 32;
        private int _blockSize = 8;

        public int Epochs
        {
            get => _epochs;
            set => _epochs = value >= 0 ? value : throw new ArgumentException("Epochs must be non-negative.", nameof(Epochs));
        }

        public int StepsPerEpoch
        {
            get => _stepsPerEpoch;
            set => _stepsPerEpoch = value > 0 ? value : throw new ArgumentException("StepsPerEpoch must be positive.", nameof(StepsPerEpoch));
        }

        public float LearningRate
        {
            get => _learningRate;
            set => _learningRate = value > 0 ? value : throw new ArgumentException("LearningRate must be positive.", nameof(LearningRate));
        }

        public int BatchSize
        {
            get => _batchSize;
            set => _batchSize = value > 0 ? value : throw new ArgumentException("BatchSize must be positive.", nameof(BatchSize));
        }

        public int BlockSize
        {
            get => _blockSize;
            set => _blockSize = value > 0 ? value : throw new ArgumentException("BlockSize must be positive.", nameof(BlockSize));
        }
    }
}