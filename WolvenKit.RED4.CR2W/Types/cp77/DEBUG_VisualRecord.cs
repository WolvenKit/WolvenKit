using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualRecord : CVariable
	{
		private CArray<CUInt32> _layerIDs;
		private wCHandle<ScriptedPuppet> _puppet;
		private CBool _infiniteDuration;
		private CFloat _showDuration;

		[Ordinal(0)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get
			{
				if (_layerIDs == null)
				{
					_layerIDs = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "layerIDs", cr2w, this);
				}
				return _layerIDs;
			}
			set
			{
				if (_layerIDs == value)
				{
					return;
				}
				_layerIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("infiniteDuration")] 
		public CBool InfiniteDuration
		{
			get
			{
				if (_infiniteDuration == null)
				{
					_infiniteDuration = (CBool) CR2WTypeManager.Create("Bool", "infiniteDuration", cr2w, this);
				}
				return _infiniteDuration;
			}
			set
			{
				if (_infiniteDuration == value)
				{
					return;
				}
				_infiniteDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get
			{
				if (_showDuration == null)
				{
					_showDuration = (CFloat) CR2WTypeManager.Create("Float", "showDuration", cr2w, this);
				}
				return _showDuration;
			}
			set
			{
				if (_showDuration == value)
				{
					return;
				}
				_showDuration = value;
				PropertySet(this);
			}
		}

		public DEBUG_VisualRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
