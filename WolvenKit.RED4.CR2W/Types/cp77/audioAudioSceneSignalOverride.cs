using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneSignalOverride : CVariable
	{
		private CName _templateSignal;
		private CName _signalOverride;

		[Ordinal(0)] 
		[RED("templateSignal")] 
		public CName TemplateSignal
		{
			get
			{
				if (_templateSignal == null)
				{
					_templateSignal = (CName) CR2WTypeManager.Create("CName", "templateSignal", cr2w, this);
				}
				return _templateSignal;
			}
			set
			{
				if (_templateSignal == value)
				{
					return;
				}
				_templateSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("signalOverride")] 
		public CName SignalOverride
		{
			get
			{
				if (_signalOverride == null)
				{
					_signalOverride = (CName) CR2WTypeManager.Create("CName", "signalOverride", cr2w, this);
				}
				return _signalOverride;
			}
			set
			{
				if (_signalOverride == value)
				{
					return;
				}
				_signalOverride = value;
				PropertySet(this);
			}
		}

		public audioAudioSceneSignalOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
