using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilities : ScannerChunk
	{
		private CArray<wCHandle<gamedataGameplayAbility_Record>> _abilities;

		[Ordinal(0)] 
		[RED("abilities")] 
		public CArray<wCHandle<gamedataGameplayAbility_Record>> Abilities
		{
			get
			{
				if (_abilities == null)
				{
					_abilities = (CArray<wCHandle<gamedataGameplayAbility_Record>>) CR2WTypeManager.Create("array:whandle:gamedataGameplayAbility_Record", "abilities", cr2w, this);
				}
				return _abilities;
			}
			set
			{
				if (_abilities == value)
				{
					return;
				}
				_abilities = value;
				PropertySet(this);
			}
		}

		public ScannerAbilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
