﻿using Model;
using System.Collections.Generic;

namespace Interface
{
    public interface ISQLFileOperate
    {
        //保存文件
        void SaveFile(SFile f);
        //通过文件id打开文件
        SFile OpenFile(int fno);

        //通过分类id读取文件列表
        List<SFile> ReadFileByCno(int cno);

        //文件类型互转
        MyFile SFileToMyFile(SFile sf);
    }
}
