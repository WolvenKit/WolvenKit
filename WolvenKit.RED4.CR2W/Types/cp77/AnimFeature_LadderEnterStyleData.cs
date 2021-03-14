using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LadderEnterStyleData : animAnimFeature
	{
		private CInt32 _enterStyle;

		[Ordinal(0)] 
		[RED("enterStyle")] 
		public CInt32 EnterStyle
		{
			get
			{
				if (_enterStyle == null)
				{
					_enterStyle = (CInt32) CR2WTypeManager.Create("Int32", "enterStyle", cr2w, this);
				}
				return _enterStyle;
			}
			set
			{
				if (_enterStyle == value)
				{
					return;
				}
				_enterStyle = value;
				PropertySet(this);
			}
		}

		public AnimFeature_LadderEnterStyleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
