using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleState : animAnimFeatureMarkUnstable
	{
		private CBool _tppEnabled;

		[Ordinal(0)] 
		[RED("tppEnabled")] 
		public CBool TppEnabled
		{
			get
			{
				if (_tppEnabled == null)
				{
					_tppEnabled = (CBool) CR2WTypeManager.Create("Bool", "tppEnabled", cr2w, this);
				}
				return _tppEnabled;
			}
			set
			{
				if (_tppEnabled == value)
				{
					return;
				}
				_tppEnabled = value;
				PropertySet(this);
			}
		}

		public AnimFeature_VehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
