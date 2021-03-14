using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<RoyceComponent> _royceComponent;
		private CArray<wCHandle<gameWeakspotObject>> _weakspots;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("royceComponent")] 
		public CHandle<RoyceComponent> RoyceComponent
		{
			get
			{
				if (_royceComponent == null)
				{
					_royceComponent = (CHandle<RoyceComponent>) CR2WTypeManager.Create("handle:RoyceComponent", "royceComponent", cr2w, this);
				}
				return _royceComponent;
			}
			set
			{
				if (_royceComponent == value)
				{
					return;
				}
				_royceComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weakspots")] 
		public CArray<wCHandle<gameWeakspotObject>> Weakspots
		{
			get
			{
				if (_weakspots == null)
				{
					_weakspots = (CArray<wCHandle<gameWeakspotObject>>) CR2WTypeManager.Create("array:whandle:gameWeakspotObject", "weakspots", cr2w, this);
				}
				return _weakspots;
			}
			set
			{
				if (_weakspots == value)
				{
					return;
				}
				_weakspots = value;
				PropertySet(this);
			}
		}

		public RoyceHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
