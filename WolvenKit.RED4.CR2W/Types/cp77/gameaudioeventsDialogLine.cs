using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsDialogLine : redEvent
	{
		private audioDialogLineEventData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public audioDialogLineEventData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (audioDialogLineEventData) CR2WTypeManager.Create("audioDialogLineEventData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
