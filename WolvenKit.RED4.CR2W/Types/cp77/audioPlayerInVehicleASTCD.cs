using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlayerInVehicleASTCD : audioAudioStateTransitionConditionData
	{
		private CBool _isInside;

		[Ordinal(1)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get
			{
				if (_isInside == null)
				{
					_isInside = (CBool) CR2WTypeManager.Create("Bool", "isInside", cr2w, this);
				}
				return _isInside;
			}
			set
			{
				if (_isInside == value)
				{
					return;
				}
				_isInside = value;
				PropertySet(this);
			}
		}

		public audioPlayerInVehicleASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
