using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameShapeData : CVariable
	{
		private gameHitResult _result;
		private CHandle<gameHitShapeUserData> _userData;
		private CName _physicsMaterial;
		private CName _hitShapeName;

		[Ordinal(0)] 
		[RED("result")] 
		public gameHitResult Result
		{
			get
			{
				if (_result == null)
				{
					_result = (gameHitResult) CR2WTypeManager.Create("gameHitResult", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<gameHitShapeUserData>) CR2WTypeManager.Create("handle:gameHitShapeUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get
			{
				if (_physicsMaterial == null)
				{
					_physicsMaterial = (CName) CR2WTypeManager.Create("CName", "physicsMaterial", cr2w, this);
				}
				return _physicsMaterial;
			}
			set
			{
				if (_physicsMaterial == value)
				{
					return;
				}
				_physicsMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get
			{
				if (_hitShapeName == null)
				{
					_hitShapeName = (CName) CR2WTypeManager.Create("CName", "hitShapeName", cr2w, this);
				}
				return _hitShapeName;
			}
			set
			{
				if (_hitShapeName == value)
				{
					return;
				}
				_hitShapeName = value;
				PropertySet(this);
			}
		}

		public gameShapeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
