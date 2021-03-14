using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSignalInstance : CVariable
	{
		private CHandle<GateSignal> _gateSignal;
		private CFloat _timeStamp;
		private CArray<CName> _consumeTags;

		[Ordinal(0)] 
		[RED("gateSignal")] 
		public CHandle<GateSignal> GateSignal
		{
			get
			{
				if (_gateSignal == null)
				{
					_gateSignal = (CHandle<GateSignal>) CR2WTypeManager.Create("handle:GateSignal", "gateSignal", cr2w, this);
				}
				return _gateSignal;
			}
			set
			{
				if (_gateSignal == value)
				{
					return;
				}
				_gateSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get
			{
				if (_timeStamp == null)
				{
					_timeStamp = (CFloat) CR2WTypeManager.Create("Float", "timeStamp", cr2w, this);
				}
				return _timeStamp;
			}
			set
			{
				if (_timeStamp == value)
				{
					return;
				}
				_timeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("consumeTags")] 
		public CArray<CName> ConsumeTags
		{
			get
			{
				if (_consumeTags == null)
				{
					_consumeTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "consumeTags", cr2w, this);
				}
				return _consumeTags;
			}
			set
			{
				if (_consumeTags == value)
				{
					return;
				}
				_consumeTags = value;
				PropertySet(this);
			}
		}

		public GateSignalInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
