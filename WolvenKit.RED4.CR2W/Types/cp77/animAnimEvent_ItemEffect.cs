using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_ItemEffect : animAnimEvent
	{
		private CName _effectName;

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_ItemEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
