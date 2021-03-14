using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlots : entIComponent
	{
		private CArray<gameAnimParamSlotsOption> _animParams;

		[Ordinal(3)] 
		[RED("animParams")] 
		public CArray<gameAnimParamSlotsOption> AnimParams
		{
			get
			{
				if (_animParams == null)
				{
					_animParams = (CArray<gameAnimParamSlotsOption>) CR2WTypeManager.Create("array:gameAnimParamSlotsOption", "animParams", cr2w, this);
				}
				return _animParams;
			}
			set
			{
				if (_animParams == value)
				{
					return;
				}
				_animParams = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
