@Html.DevExpress().GridView(Me.CreateGridViewSettings(CType(ViewData("gridType"), GridType))).Bind(Model).GetHtml()