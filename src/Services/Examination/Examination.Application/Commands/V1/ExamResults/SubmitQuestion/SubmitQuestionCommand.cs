using Examination.Shared.ExamResults;
using Examination.Shared.SeedWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Application.Commands.V1.ExamResults.SubmitQuestion
{
    public class SubmitQuestionCommand : IRequest<ApiResult<ExamResultDto>>
    {
        public string ExamResultId { get; set; }

        public string QuestionId { get; set; }

        public List<string> AnswerIds { get; set; }
    }
}
