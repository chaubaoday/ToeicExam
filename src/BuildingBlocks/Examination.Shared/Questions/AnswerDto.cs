using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.Questions
{
    //chua cac thuc tinh cua dap an
    public class AnswerDto
    {
        public string Id { get; set; }
        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public Guid ClientId { set; get; } = Guid.NewGuid();
    }
}