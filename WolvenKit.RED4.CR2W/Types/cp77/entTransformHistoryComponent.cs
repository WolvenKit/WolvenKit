using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTransformHistoryComponent : entIComponent
	{
		private CFloat _historyLength;
		private CUInt32 _samplesAmount;

		[Ordinal(3)] 
		[RED("historyLength")] 
		public CFloat HistoryLength
		{
			get
			{
				if (_historyLength == null)
				{
					_historyLength = (CFloat) CR2WTypeManager.Create("Float", "historyLength", cr2w, this);
				}
				return _historyLength;
			}
			set
			{
				if (_historyLength == value)
				{
					return;
				}
				_historyLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("samplesAmount")] 
		public CUInt32 SamplesAmount
		{
			get
			{
				if (_samplesAmount == null)
				{
					_samplesAmount = (CUInt32) CR2WTypeManager.Create("Uint32", "samplesAmount", cr2w, this);
				}
				return _samplesAmount;
			}
			set
			{
				if (_samplesAmount == value)
				{
					return;
				}
				_samplesAmount = value;
				PropertySet(this);
			}
		}

		public entTransformHistoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
