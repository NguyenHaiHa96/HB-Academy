using System.Collections.Generic;
using Sirenix.Utilities;
using Sirenix.OdinInspector;

namespace PackagesDemo
{
    public class ItemGlobalDataConfig : GlobalConfig<ItemGlobalDataConfig>
    {
        public string path;
        public List<OdinItemDataConfig> itemDataConfigs = new();
        
        [Button]
        private void LoadItemDataConfig()
        {
            
        }
    }
}