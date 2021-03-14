using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		private gsmSavingRequesResult _savingComplete;

		[Ordinal(6)] 
		[RED("SavingComplete")] 
		public gsmSavingRequesResult SavingComplete
		{
			get
			{
				if (_savingComplete == null)
				{
					_savingComplete = (gsmSavingRequesResult) CR2WTypeManager.Create("gsmSavingRequesResult", "SavingComplete", cr2w, this);
				}
				return _savingComplete;
			}
			set
			{
				if (_savingComplete == value)
				{
					return;
				}
				_savingComplete = value;
				PropertySet(this);
			}
		}

		public gsmBaseRequestsHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
