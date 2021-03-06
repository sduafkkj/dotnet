﻿namespace BL.StandardDictionary
{
    /// <summary>
    ///高等学校档案实体分类法 JYT1001
    /// </summary>
    public class DicArchiveCategory : DicItem
    {
        protected override DicItem[] AllOption()
        {
            return new[]{
                new DicItem("DQ","党群"),
                new DicItem("DQ11","党务综合分党委、总支、直属支部综合材料入此"),
                new DicItem("DQ12","纪检"),
                new DicItem("DQ13","组织"),
                new DicItem("DQ14","宣传教育"),
                new DicItem("DQ15","统战民主党派材料入此"),
                new DicItem("DQ16","工会妇女工作材料入此"),
                new DicItem("DQ16","团委学生社团材料入此"),
                new DicItem("XZ","行政"),
                new DicItem("XZ11","综合教职工代表大会和院、系、所等单位综合材料入此"),
                new DicItem("XZ12","人事师资培养材料入此"),
                new DicItem("XZ13","监察审计"),
                new DicItem("XZ14","武装保卫"),
                new DicItem("XZ15","总务"),
                new DicItem("XZ16","档案、图书、文博"),
                new DicItem("JX","教学"),
                new DicItem("JX11","综合"),
                new DicItem("JX12","研究生教育"),
                new DicItem("JX13","全日制本、专科教育"),
                new DicItem("JX14","成人教育"),
                new DicItem("KY","科学研究"),
                new DicItem("KY11","综合科研经费管理、学术活动材料入此"),
                new DicItem("KY12","按学科或专业或项目设置类目"),
                new DicItem("CP","产品生产与科技开发"),
                new DicItem("CP11","综合"),
                new DicItem("CP12","按产品种类或项目设置类目"),
                new DicItem("JJ","基本建设"),
                new DicItem("JJ11","综合"),
                new DicItem("JJ12","按单项工程设置类目"),
                new DicItem("SB","仪器设备"),
                new DicItem("SB11","综合"),
                new DicItem("SB12","按仪器设备种类或型号设置类目"),
                new DicItem("CB","出版"),
                new DicItem("CB11","综合"),
                new DicItem("CB12","报纸"),
                new DicItem("CB13","刊物"),
                new DicItem("CB14","书稿"),
                new DicItem("CB15","音像"),
                new DicItem("WS","外事"),
                new DicItem("WS11","综合"),
                //new DicItem("WS12","出国（境）国际合作与会议材料入 WSl4 "),
                //new DicItem("WS13","来校外国留学生工作材料入 WS15 国际合作与会议材料入 WS11 "),
                new DicItem("WS14","国际合作与会议"),
                new DicItem("WS15","外国留学生工作"),
                new DicItem("CK","财会"),
                new DicItem("CK11","综合"),
                new DicItem("CK12","会计报表"),
                new DicItem("CK13","会计帐簿"),
                new DicItem("CK14","会计凭证"),
                new DicItem("CK15","工资清册奖金，助学金入此"),
                new DicItem("SX","声像"),
                new DicItem("SX12","照片"),
                new DicItem("SX13","录音带"),
                new DicItem("SX14","录像带"),
                new DicItem("SX15","幻灯片"),
                new DicItem("SX16","磁盘"),
                new DicItem("SX17","影视胶片"),
                new DicItem("SX18","缩微胶片"),
                new DicItem("SX19","光盘"),
                new DicItem("RW","人物"),
                new DicItem("RW11","名人"),
                new DicItem("RW12","科研教学骨干"),
                new DicItem("RW13","已故人员"),
                new DicItem("SW","实物"),
                new DicItem("SW11","织物类"),
                new DicItem("SW12","纸质类"),
                new DicItem("SW13","画册"),
                new DicItem("SW14","珍贵物品"),
                new DicItem("SW15","其他物品"),
                new DicItem("XS","学生"),
                new DicItem("XS11","高中档案"),
                new DicItem("XS12","入学登记表"),
                new DicItem("XS13","体检表"),
                new DicItem("XS14","学籍档案"),
                new DicItem("XS15","奖惩记录"),
                new DicItem("XS16","党团组织档案"),
                new DicItem("XS17","毕业生登记表"),
            };
            
        }
    }
}
