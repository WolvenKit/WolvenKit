using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerTargetChangedRequest : gameScriptableSystemRequest
	{
		private entEntityID _scannerTarget;

		[Ordinal(0)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get
			{
				if (_scannerTarget == null)
				{
					_scannerTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "scannerTarget", cr2w, this);
				}
				return _scannerTarget;
			}
			set
			{
				if (_scannerTarget == value)
				{
					return;
				}
				_scannerTarget = value;
				PropertySet(this);
			}
		}

		public ScannerTargetChangedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
