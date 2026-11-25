#!/usr/bin/env python3
"""
Groups changed .cs files by their top-level folder, finds the .csproj in that
folder, and runs `dotnet format style` on each project scoped to only the
changed files belonging to it.

Intended to be invoked from CI with the list of changed files, e.g.:

    python tools/dotnet_format_changed.py --files "WolvenKit/Foo.cs" "WolvenKit.Core/Bar.cs"

or reading changed files from a newline-separated file:

    python tools/dotnet_format_changed.py --files-from changed_files.txt

or from an environment variable (space or newline separated):

    CHANGED_FILES="WolvenKit/Foo.cs WolvenKit.Core/Bar.cs" python tools/dotnet_format_changed.py --files-env CHANGED_FILES
"""

from __future__ import annotations

import argparse
import os
import subprocess
import sys
from collections import defaultdict
from pathlib import Path


def find_csproj(top_dir: Path) -> Path | None:
    """Return the first .csproj file directly inside top_dir, if any."""
    if not top_dir.is_dir():
        return None
    matches = sorted(top_dir.glob("*.csproj"))
    return matches[0] if matches else None


def group_files_by_project(
    changed_files: list[str], repo_root: Path
) -> dict[Path, list[str]]:
    """
    Groups changed file paths (relative to repo root, using '/' separators)
    by the .csproj found in their top-level folder. Returns a dict mapping
    csproj path -> list of file paths relative to REPO ROOT (not the csproj's
    directory), since `dotnet format --include` resolves paths relative to
    the current working directory the command is invoked from, not the
    project file's directory.
    """
    grouped: dict[Path, list[str]] = defaultdict(list)

    for raw_path in changed_files:
        raw_path = raw_path.strip()
        if not raw_path or not raw_path.endswith(".cs"):
            continue

        # Normalize to forward slashes regardless of platform / git output.
        rel_path = raw_path.replace("\\", "/")
        parts = rel_path.split("/", 1)

        if len(parts) < 2:
            print(
                f"::warning file={raw_path}::File is at repo root, no top-level "
                f"project folder found, skipping",
                file=sys.stderr,
            )
            continue

        top_dir_name, _remainder = parts
        top_dir = repo_root / top_dir_name

        csproj = find_csproj(top_dir)
        if csproj is None:
            print(
                f"::warning file={raw_path}::No .csproj found in "
                f"'{top_dir_name}', skipping",
                file=sys.stderr,
            )
            continue

        # Keep the full path relative to repo root (e.g. "WolvenKit/ViewModels/Foo.cs"),
        # not stripped down to the project-relative remainder.
        grouped[csproj].append(rel_path)

    return grouped


def run_dotnet_format(csproj: Path, files: list[str], severity: str, cwd: Path) -> int:
    # csproj is an absolute path here (repo_root / top_dir / *.csproj was
    # resolved via glob against an already-resolved repo_root), so pass it
    # through as-is. --include entries are relative to `cwd` (the repo root),
    # since that's what dotnet format resolves them against, not the csproj's
    # own directory.
    include_arg = ";".join(files)
    cmd = [
        "dotnet",
        "format",
        str(csproj),
        "--include",
        include_arg,
        "--severity",
        severity,
        "-v",
        "diagnostic",
        # diagnostics know to cause crashes
        "--exclude-diagnostics",
        # IDE0130 => Namespace does not match folder structure
        "IDE0130"
    ]

    print(f"Formatting {csproj} -> {include_arg}")
    print(f"Running: {' '.join(cmd)}")

    env = os.environ.copy()
    # Allows design-time build / restore of Windows-targeted projects on
    # non-Windows runners (e.g. net8.0-windows on a Linux GitHub runner).
    env.setdefault("EnableWindowsTargeting", "true")

    result = subprocess.run(cmd, cwd=cwd, env=env)
    return result.returncode


def parse_files_arg(args: argparse.Namespace) -> list[str]:
    if args.files:
        return args.files

    if args.files_from:
        content = Path(args.files_from).read_text(encoding="utf-8")
        return [line for line in content.splitlines() if line.strip()]

    if args.files_env:
        raw = os.environ.get(args.files_env, "")
        # Support both space- and newline-separated lists.
        return [f for f in raw.replace("\n", " ").split(" ") if f.strip()]

    return []


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "--files",
        nargs="*",
        help="Changed file paths relative to repo root",
    )
    parser.add_argument(
        "--files-from",
        help="Path to a newline-separated file listing changed files",
    )
    parser.add_argument(
        "--files-env",
        help="Name of an environment variable containing changed files "
        "(space or newline separated)",
    )
    parser.add_argument(
        "--repo-root",
        default=".",
        help="Repository root directory (default: current directory)",
    )
    parser.add_argument(
        "--severity",
        default="info",
        help="Minimum severity for dotnet format to apply (default: info)",
    )
    parser.add_argument(
        "--fail-on-error",
        action="store_true",
        help="Exit non-zero if any dotnet format invocation fails "
        "(default: continue and report at the end)",
    )
    args = parser.parse_args()

    changed_files = parse_files_arg(args)
    if not changed_files:
        print("No changed .cs files provided, nothing to format.")
        return 0

    repo_root = Path(args.repo_root).resolve()
    grouped = group_files_by_project(changed_files, repo_root)

    if not grouped:
        print("No changed files mapped to a project, nothing to format.")
        return 0

    had_failure = False
    for csproj, files in grouped.items():
        exit_code = run_dotnet_format(csproj, files, args.severity, cwd=repo_root)
        if exit_code != 0:
            had_failure = True
            print(
                f"::error::dotnet format failed for {csproj} with exit code {exit_code}",
                file=sys.stderr,
            )

    if had_failure and args.fail_on_error:
        return 1
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
