using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetAnimationManager : IScriptable
	{
		private CArray<SWidgetAnimationData> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<SWidgetAnimationData> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<SWidgetAnimationData>) CR2WTypeManager.Create("array:SWidgetAnimationData", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		public WidgetAnimationManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
