using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		private CName _signalName;
		private CFloat _signalDuration;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get
			{
				if (_signalName == null)
				{
					_signalName = (CName) CR2WTypeManager.Create("CName", "signalName", cr2w, this);
				}
				return _signalName;
			}
			set
			{
				if (_signalName == value)
				{
					return;
				}
				_signalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("signalDuration")] 
		public CFloat SignalDuration
		{
			get
			{
				if (_signalDuration == null)
				{
					_signalDuration = (CFloat) CR2WTypeManager.Create("Float", "signalDuration", cr2w, this);
				}
				return _signalDuration;
			}
			set
			{
				if (_signalDuration == value)
				{
					return;
				}
				_signalDuration = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_SendActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
