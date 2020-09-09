using eat_rice_databases.database;
using eat_rice_model.entity.common;
using eat_rice_model.entity.homeworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eat_rice_service.masterService
{
    public class MasterService
    {

        /// <summary>
        /// 가디언 토벌 마스터 리스트
        /// </summary>
        public List<Subjugation> GetSubjugationHomeworks()
        {
            return DB.가디언토벌_리스트;
        }
    }
}
