using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		private CUInt8 _masterInputIdx;

		[Ordinal(5)] 
		[RED("masterInputIdx")] 
		public CUInt8 MasterInputIdx
		{
			get
			{
				if (_masterInputIdx == null)
				{
					_masterInputIdx = (CUInt8) CR2WTypeManager.Create("Uint8", "masterInputIdx", cr2w, this);
				}
				return _masterInputIdx;
			}
			set
			{
				if (_masterInputIdx == value)
				{
					return;
				}
				_masterInputIdx = value;
				PropertySet(this);
			}
		}

		public animMotionTableProvider_MasterSlaveBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
