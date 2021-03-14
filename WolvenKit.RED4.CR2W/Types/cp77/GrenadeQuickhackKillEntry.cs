using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeQuickhackKillEntry : CVariable
	{
		private wCHandle<gameObject> _source;
		private CArray<wCHandle<gameObject>> _targets;
		private CArray<CFloat> _timestamps;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CArray<wCHandle<gameObject>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timestamps")] 
		public CArray<CFloat> Timestamps
		{
			get
			{
				if (_timestamps == null)
				{
					_timestamps = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "timestamps", cr2w, this);
				}
				return _timestamps;
			}
			set
			{
				if (_timestamps == value)
				{
					return;
				}
				_timestamps = value;
				PropertySet(this);
			}
		}

		public GrenadeQuickhackKillEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
