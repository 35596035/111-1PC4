# 第4次練習-練習-PC4
>
>學號：109111101
><br />
>姓名：邱韋翔
><br />
>作業撰寫時間：15 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/09/21
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容
根據第一小題的題目要求，改成巢狀格式，一開始先給予變數`i_Age`,`i_Sex`，再來我是用`i_Sex`就是用性別來做判斷
，如果`i_Sex`等於1或0就執行相對應的程式碼，然後再根據年齡去區分；如果`i_Sex`不等於1或0就執行外圍`else`的部分輸出其他
，下段程式碼為使用後結果:
```csharp
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 49; int i_Sex = 0;
            if (i_Sex == 1)
            {
                if (i_Age >= 50)
                {
                    Response.Write("壯年男人的程式執行程式碼區域");
                }
                else
                {
                    Response.Write("年輕男人的程式執行程式碼區域");
                }
            }
            else if (i_Sex == 0)
            {
                if (i_Age >= 50)
                {
                    Response.Write("壯年女人的程式執行程式碼區域");
                }
                else
                {
                    Response.Write("年輕女人的程式執行程式碼區域");
                }
            }
            else
            {
                Response.Write("其他");
            }
        }
```

根據第二題題目要求，使用笛摩根定律更改程式碼，一開始我原本想使用巢狀結構來完成
，但後面發現好像行不通，所以就換成原本題目的方式來進行修改，那因為題目規定無法顯示
&符號所以用||(OR)來執行，運用!(NOT)的方式，讓結果等於題目使用AND的答案，下段程式碼為使用後結果:
```csharp
protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 49; int i_Sex = 0;
            if (!(!(i_Age >= 50) || !(i_Sex == 1)))
            {
                Response.Write("壯年男人的程式執行程式碼區域");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 1)))
            {
                Response.Write("年輕男人的程式執行程式碼區域");
            }
            else if (!(!(i_Age >= 50) || !(i_Sex == 0)))
            {
                Response.Write("壯年女人的程式執行程式碼區域");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 0)))
            {
                Response.Write("年輕女人的程式執行程式碼區域");
            }
            else
            {
                Response.Write("其他");
            }
        }
```



## 個人認為完成作業須具備觀念

此次題目需要清楚了解`if`、`else`、`else if`語法的用法，再來須了解邏輯運算子AND(`&&`)、OR(`||`)和NOT(`!`)的特性，
還有了解什麼叫巢狀結構，第一題其實有其他作法不一定需要以`i_Sex`當一開始的判斷也可以從年齡`i_Age`開始判斷，但程式碼就會變得較長，
所以這次作業也可以去反覆思考有沒有其他的做法能盡可能的縮短程式碼的部分，以此提升自身邏輯能力。

