using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDefaultMixingSignposts : audioAudioMetadata
	{
		private CName _endOfCombat;
		private CName _inCombat;
		private CName _inStealth;
		private CName _aiAlerted;
		private CName _sceneBootstrapSignpost;
		private CArray<CName> _reservedSignposts;

		[Ordinal(1)] 
		[RED("endOfCombat")] 
		public CName EndOfCombat
		{
			get
			{
				if (_endOfCombat == null)
				{
					_endOfCombat = (CName) CR2WTypeManager.Create("CName", "endOfCombat", cr2w, this);
				}
				return _endOfCombat;
			}
			set
			{
				if (_endOfCombat == value)
				{
					return;
				}
				_endOfCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inCombat")] 
		public CName InCombat
		{
			get
			{
				if (_inCombat == null)
				{
					_inCombat = (CName) CR2WTypeManager.Create("CName", "inCombat", cr2w, this);
				}
				return _inCombat;
			}
			set
			{
				if (_inCombat == value)
				{
					return;
				}
				_inCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inStealth")] 
		public CName InStealth
		{
			get
			{
				if (_inStealth == null)
				{
					_inStealth = (CName) CR2WTypeManager.Create("CName", "inStealth", cr2w, this);
				}
				return _inStealth;
			}
			set
			{
				if (_inStealth == value)
				{
					return;
				}
				_inStealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("aiAlerted")] 
		public CName AiAlerted
		{
			get
			{
				if (_aiAlerted == null)
				{
					_aiAlerted = (CName) CR2WTypeManager.Create("CName", "aiAlerted", cr2w, this);
				}
				return _aiAlerted;
			}
			set
			{
				if (_aiAlerted == value)
				{
					return;
				}
				_aiAlerted = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sceneBootstrapSignpost")] 
		public CName SceneBootstrapSignpost
		{
			get
			{
				if (_sceneBootstrapSignpost == null)
				{
					_sceneBootstrapSignpost = (CName) CR2WTypeManager.Create("CName", "sceneBootstrapSignpost", cr2w, this);
				}
				return _sceneBootstrapSignpost;
			}
			set
			{
				if (_sceneBootstrapSignpost == value)
				{
					return;
				}
				_sceneBootstrapSignpost = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reservedSignposts")] 
		public CArray<CName> ReservedSignposts
		{
			get
			{
				if (_reservedSignposts == null)
				{
					_reservedSignposts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "reservedSignposts", cr2w, this);
				}
				return _reservedSignposts;
			}
			set
			{
				if (_reservedSignposts == value)
				{
					return;
				}
				_reservedSignposts = value;
				PropertySet(this);
			}
		}

		public audioDefaultMixingSignposts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
