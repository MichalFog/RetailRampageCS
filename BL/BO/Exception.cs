namespace BO
{
    [Serializable]
    public class BL_NoExistException : Exception // הישות לא נמצאה
    {
        public BL_NoExistException(string? message) : base(message) { }
        public BL_NoExistException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    [Serializable]
    public class BL_ExistException : Exception // הישות קיימת כבר
    {
        public BL_ExistException(string? message) : base(message) { }
        public BL_ExistException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    [Serializable]
    public class BL_InvalidInputException : Exception // קלט לא תקין
    {
        public BL_InvalidInputException(string? message) : base(message) { }
        public BL_InvalidInputException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    [Serializable]
    public class BL_OperationFailedException : Exception // פעולה נכשלה מסיבה פנימית
    {
        public BL_OperationFailedException(string? message) : base(message) { }
        public BL_OperationFailedException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}