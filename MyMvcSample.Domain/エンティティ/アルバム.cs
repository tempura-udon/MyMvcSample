using MyMvcSample.Domain.バリデーション;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMvcSample.Domain.エンティティ
{
    public class アルバム
    {
        public int アルバムID { get; set; }
        public int ジャンルID { get; set; }
        public int アーティストID { get; set; }
        public int タイトル { get; set; }
        public decimal 価格 { get; set; }
        public string アルバムアートURL { get; set; }

        public virtual ジャンル ジャンル { get; set; }
        public virtual アーティスト アーティスト { get; set; }

        public virtual ICollection<注文明細> 注文明細群 { get; set; }
        public バリデーション結果 バリデーション結果 { get; private set; }
        public bool IsValid
        {
            get
            {
                // TODO: あとで
                return true;
            }
            
        }
    }
}
