using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEffect : resStreamedResource
	{
		private CName _name;
		private CFloat _length;
		private CArray<CName> _inputParameterNames;
		private CHandle<effectTrackGroup> _trackRoot;
		private CArray<CHandle<effectTrackItem>> _events;
		private CArray<effectLoopData> _effectLoops;

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CFloat) CR2WTypeManager.Create("Float", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputParameterNames")] 
		public CArray<CName> InputParameterNames
		{
			get
			{
				if (_inputParameterNames == null)
				{
					_inputParameterNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "inputParameterNames", cr2w, this);
				}
				return _inputParameterNames;
			}
			set
			{
				if (_inputParameterNames == value)
				{
					return;
				}
				_inputParameterNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("trackRoot")] 
		public CHandle<effectTrackGroup> TrackRoot
		{
			get
			{
				if (_trackRoot == null)
				{
					_trackRoot = (CHandle<effectTrackGroup>) CR2WTypeManager.Create("handle:effectTrackGroup", "trackRoot", cr2w, this);
				}
				return _trackRoot;
			}
			set
			{
				if (_trackRoot == value)
				{
					return;
				}
				_trackRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("events")] 
		public CArray<CHandle<effectTrackItem>> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArray<CHandle<effectTrackItem>>) CR2WTypeManager.Create("array:handle:effectTrackItem", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("effectLoops")] 
		public CArray<effectLoopData> EffectLoops
		{
			get
			{
				if (_effectLoops == null)
				{
					_effectLoops = (CArray<effectLoopData>) CR2WTypeManager.Create("array:effectLoopData", "effectLoops", cr2w, this);
				}
				return _effectLoops;
			}
			set
			{
				if (_effectLoops == value)
				{
					return;
				}
				_effectLoops = value;
				PropertySet(this);
			}
		}

		public worldEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
