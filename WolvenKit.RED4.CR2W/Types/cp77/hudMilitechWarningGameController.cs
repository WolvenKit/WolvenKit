using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudMilitechWarningGameController : gameuiHUDGameController
	{
		private wCHandle<inkCompoundWidget> _root;
		private CHandle<inkanimProxy> _anim;
		private CUInt32 _factListenerId;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
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

		[Ordinal(10)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get
			{
				if (_anim == null)
				{
					_anim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim", cr2w, this);
				}
				return _anim;
			}
			set
			{
				if (_anim == value)
				{
					return;
				}
				_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get
			{
				if (_factListenerId == null)
				{
					_factListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "factListenerId", cr2w, this);
				}
				return _factListenerId;
			}
			set
			{
				if (_factListenerId == value)
				{
					return;
				}
				_factListenerId = value;
				PropertySet(this);
			}
		}

		public hudMilitechWarningGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
