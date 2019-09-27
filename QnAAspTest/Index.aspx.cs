using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;
 
using System.Linq;
using System.Threading.Tasks;
namespace QnAAspTest
{

    public partial class Index : System.Web.UI.Page
    {
        string subscriptionKey = "05fb5af531224dad94d656854bbc5b70";

     

        protected void btnadd_click(Object sender, EventArgs e)
        {
          

       
        }

        protected   void btncomplete_clickAsync(Object sender, EventArgs e)
        {
            Complete();
        }

        public async void Complete()
        {
            try
            {
           
                var client = new QnAMakerClient(new ApiKeyServiceClientCredentials(subscriptionKey)) { Endpoint = "https://westus.api.cognitive.microsoft.com" };


                List<QnADTO> myqnamaker = new List<QnADTO>();

                myqnamaker.Add(new QnADTO { Questions = new List<string> { txtquestion.Value }, Answer = txtanswer.Value });


                var updateOp = await client.Knowledgebase.UpdateAsync("d64a9dff-eefc-4c9b-9da9-7a6f553f4efd", new UpdateKbOperationDTO
                {
                    // Create JSON of changes 
                    Add = new UpdateKbOperationDTOAdd { QnaList = myqnamaker },
                    Update = null,
                    Delete = null
                });

                client.Knowledgebase.PublishAsync("d64a9dff-eefc-4c9b-9da9-7a6f553f4efd").Wait();


            }
            catch (Exception ex)
            {
                txtresponse.InnerText = ex.Message;
            }

        }
    }
}
