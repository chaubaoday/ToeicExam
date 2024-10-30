using System;

namespace Examination.Domain.Exceptions
{

    //dung de thong bao ngoai le
    public class ExamDomainException : Exception
    {
        public ExamDomainException()
        { }

        public ExamDomainException(string message)
            : base(message)
        { }

        public ExamDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}