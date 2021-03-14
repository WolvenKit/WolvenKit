using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		private LinkedFocusClueData _linkedCluekData;
		private CBool _forceUpdate;

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

		[Ordinal(1)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get
			{
				if (_forceUpdate == null)
				{
					_forceUpdate = (CBool) CR2WTypeManager.Create("Bool", "forceUpdate", cr2w, this);
				}
				return _forceUpdate;
			}
			set
			{
				if (_forceUpdate == value)
				{
					return;
				}
				_forceUpdate = value;
				PropertySet(this);
			}
		}

		public RegisterLinkedCluekRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
