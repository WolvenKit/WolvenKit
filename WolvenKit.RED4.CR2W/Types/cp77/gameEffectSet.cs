using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectSet : CResource
	{
		private CArray<gameEffectDefinition> _effects;

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectDefinition> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<gameEffectDefinition>) CR2WTypeManager.Create("array:gameEffectDefinition", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		public gameEffectSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
