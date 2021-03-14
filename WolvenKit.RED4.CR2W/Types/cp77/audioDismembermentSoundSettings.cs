using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDismembermentSoundSettings : audioAudioMetadata
	{
		private CName _headEvent;
		private CName _armEvent;
		private CName _legEvent;

		[Ordinal(1)] 
		[RED("headEvent")] 
		public CName HeadEvent
		{
			get
			{
				if (_headEvent == null)
				{
					_headEvent = (CName) CR2WTypeManager.Create("CName", "headEvent", cr2w, this);
				}
				return _headEvent;
			}
			set
			{
				if (_headEvent == value)
				{
					return;
				}
				_headEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("armEvent")] 
		public CName ArmEvent
		{
			get
			{
				if (_armEvent == null)
				{
					_armEvent = (CName) CR2WTypeManager.Create("CName", "armEvent", cr2w, this);
				}
				return _armEvent;
			}
			set
			{
				if (_armEvent == value)
				{
					return;
				}
				_armEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("legEvent")] 
		public CName LegEvent
		{
			get
			{
				if (_legEvent == null)
				{
					_legEvent = (CName) CR2WTypeManager.Create("CName", "legEvent", cr2w, this);
				}
				return _legEvent;
			}
			set
			{
				if (_legEvent == value)
				{
					return;
				}
				_legEvent = value;
				PropertySet(this);
			}
		}

		public audioDismembermentSoundSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
