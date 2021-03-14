using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputState : CVariable
	{
		private CUInt32 _frameId;

		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get
			{
				if (_frameId == null)
				{
					_frameId = (CUInt32) CR2WTypeManager.Create("Uint32", "frameId", cr2w, this);
				}
				return _frameId;
			}
			set
			{
				if (_frameId == value)
				{
					return;
				}
				_frameId = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
