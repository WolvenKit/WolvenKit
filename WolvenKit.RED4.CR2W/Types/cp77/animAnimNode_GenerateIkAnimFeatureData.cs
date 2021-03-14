using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GenerateIkAnimFeatureData : animAnimNode_OnePoseInput
	{
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(12)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get
			{
				if (_ikChainSettings == null)
				{
					_ikChainSettings = (CArray<animIKChainSettings>) CR2WTypeManager.Create("array:animIKChainSettings", "ikChainSettings", cr2w, this);
				}
				return _ikChainSettings;
			}
			set
			{
				if (_ikChainSettings == value)
				{
					return;
				}
				_ikChainSettings = value;
				PropertySet(this);
			}
		}

		public animAnimNode_GenerateIkAnimFeatureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
