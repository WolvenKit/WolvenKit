using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseSubtitleLineLogicController : inkWidgetLogicController
	{
		private CHandle<inkWidget> _root;
		private CBool _isKiroshiEnabled;
		private CFloat _c_tier1_duration;
		private CFloat _c_tier2_duration;

		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isKiroshiEnabled")] 
		public CBool IsKiroshiEnabled
		{
			get
			{
				if (_isKiroshiEnabled == null)
				{
					_isKiroshiEnabled = (CBool) CR2WTypeManager.Create("Bool", "isKiroshiEnabled", cr2w, this);
				}
				return _isKiroshiEnabled;
			}
			set
			{
				if (_isKiroshiEnabled == value)
				{
					return;
				}
				_isKiroshiEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("c_tier1_duration")] 
		public CFloat C_tier1_duration
		{
			get
			{
				if (_c_tier1_duration == null)
				{
					_c_tier1_duration = (CFloat) CR2WTypeManager.Create("Float", "c_tier1_duration", cr2w, this);
				}
				return _c_tier1_duration;
			}
			set
			{
				if (_c_tier1_duration == value)
				{
					return;
				}
				_c_tier1_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("c_tier2_duration")] 
		public CFloat C_tier2_duration
		{
			get
			{
				if (_c_tier2_duration == null)
				{
					_c_tier2_duration = (CFloat) CR2WTypeManager.Create("Float", "c_tier2_duration", cr2w, this);
				}
				return _c_tier2_duration;
			}
			set
			{
				if (_c_tier2_duration == value)
				{
					return;
				}
				_c_tier2_duration = value;
				PropertySet(this);
			}
		}

		public BaseSubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
