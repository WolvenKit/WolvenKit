using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worlduiIWidgetGameController : inkIWidgetController
	{
		private TweakDBID _elementRecordID;

		[Ordinal(1)] 
		[RED("elementRecordID")] 
		public TweakDBID ElementRecordID
		{
			get
			{
				if (_elementRecordID == null)
				{
					_elementRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "elementRecordID", cr2w, this);
				}
				return _elementRecordID;
			}
			set
			{
				if (_elementRecordID == value)
				{
					return;
				}
				_elementRecordID = value;
				PropertySet(this);
			}
		}

		public worlduiIWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
