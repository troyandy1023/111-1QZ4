﻿# 第4次隨堂-隨堂-QZ4
>
>學號：109111103
><br />
>姓名：曾昱翔
><br />
>作業撰寫時間：80 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/12/5
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

```csharp
建立Test連接字串的區域變數
 public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_ConnS = "";

            s_ConnS = "Data Source=(localdb)\\ProjectModels;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";

顯示出dbo.Users裡的使用者和資料
            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                SqlCommand o_Com = new SqlCommand("select * from Users",o_Conn);
                o_Conn.Open();
                SqlDataReader o_R = o_Com.ExecuteReader();
                for (; o_R.Read();)
                {
                    for (int i_Col = 0; i_Col < o_R.FieldCount; i_Col++)
                    {
                        Response.Write("&nbsp;&nbsp;" + o_R[i_Col].ToString());
                    }
                    Response.Write("<br />");
                }
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

此次的隋棠很需要跟sql有關的語法和觀念，否則很難做出來，
不但要知道怎麼讓程式去抓資料，還要知道怎麼直接在sql中操作。

