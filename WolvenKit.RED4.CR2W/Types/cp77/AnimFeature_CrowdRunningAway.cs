using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CrowdRunningAway : animAnimFeature
	{
		private CBool _isRunningAwayFromPlayersCar;

		[Ordinal(0)] 
		[RED("isRunningAwayFromPlayersCar")] 
		public CBool IsRunningAwayFromPlayersCar
		{
			get
			{
				if (_isRunningAwayFromPlayersCar == null)
				{
					_isRunningAwayFromPlayersCar = (CBool) CR2WTypeManager.Create("Bool", "isRunningAwayFromPlayersCar", cr2w, this);
				}
				return _isRunningAwayFromPlayersCar;
			}
			set
			{
				if (_isRunningAwayFromPlayersCar == value)
				{
					return;
				}
				_isRunningAwayFromPlayersCar = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CrowdRunningAway(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
