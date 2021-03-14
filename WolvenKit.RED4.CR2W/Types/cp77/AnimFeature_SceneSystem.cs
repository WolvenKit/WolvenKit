using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneSystem : animAnimFeature
	{
		private CInt32 _tier;

		[Ordinal(0)] 
		[RED("tier")] 
		public CInt32 Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CInt32) CR2WTypeManager.Create("Int32", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SceneSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
