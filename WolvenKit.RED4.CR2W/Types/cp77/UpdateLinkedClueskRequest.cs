using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateLinkedClueskRequest : gameScriptableSystemRequest
	{
		private LinkedFocusClueData _linkedCluekData;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get
			{
				if (_linkedCluekData == null)
				{
					_linkedCluekData = (LinkedFocusClueData) CR2WTypeManager.Create("LinkedFocusClueData", "linkedCluekData", cr2w, this);
				}
				return _linkedCluekData;
			}
			set
			{
				if (_linkedCluekData == value)
				{
					return;
				}
				_linkedCluekData = value;
				PropertySet(this);
			}
		}

		public UpdateLinkedClueskRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
