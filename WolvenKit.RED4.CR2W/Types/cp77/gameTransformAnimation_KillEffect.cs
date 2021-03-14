using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_KillEffect : gameTransformAnimation_Effects
	{
		private CName _effectTag;

		[Ordinal(0)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get
			{
				if (_effectTag == null)
				{
					_effectTag = (CName) CR2WTypeManager.Create("CName", "effectTag", cr2w, this);
				}
				return _effectTag;
			}
			set
			{
				if (_effectTag == value)
				{
					return;
				}
				_effectTag = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_KillEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
