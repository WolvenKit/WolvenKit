// MIT License
//Copyright(c) 2018 LaughingLeader

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.MVVM.Model
{
    public static class GitHelper
    {
        #region Methods

        public static async Task<bool> Archive(ILoggerService loggerService, string repoPath, string outputFileName, bool useAttributesFile = true)
        {
            try
            {
                //Directory.CreateDirectory(Path.GetDirectoryName(OutputFileName));

                var command = "git archive --format=zip HEAD --output=\"" + outputFileName + "\"";

                //string command = "git archive master > --output=\"" + OutputFileName + "\"";
                //command += Environment.NewLine + "tar -rf " + OutputFileName + " .git";
                if (useAttributesFile)
                {
                    //command += " --worktree-attributes";
                }

                var exitCode = await ProcessHelper.RunCommandLineAsync(loggerService, repoPath, command);
                return exitCode == 0;
            }
            catch (Exception ex)
            {
                loggerService.Error($"Error creating git archive: {ex.ToString()}");
            }
            return false;
        }

        public static async Task<bool> Commit(ILoggerService loggerService, string repoPath, string commitMessage)
        {
            try
            {
                //await ProcessHelper.RunCommandLineAsync(RepoPath, "git add -A");
                var exitCode = await ProcessHelper.RunCommandLineAsync(loggerService, repoPath, "git add -A", "git commit -m \"" + commitMessage + "\"");
                return exitCode == 0;
            }
            catch (Exception ex)
            {
                loggerService.Error($"Error creating commit for git repository: {ex.ToString()}");
            }
            return false;
        }

        public static async Task<bool> InitRepository(ILoggerService loggerService, string RepoPath, string templatedir = "", string AuthorName = "", string Email = "")
        {
            try
            {
                if (!Directory.Exists(RepoPath))
                {
                    Directory.CreateDirectory(RepoPath);
                }

                var initargs = "git init";
                if (!string.IsNullOrEmpty(templatedir))
                {
                    initargs += $" --template={templatedir}";
                }

                var commands = new List<string>()
                {
                    initargs,
                    "git config core.longpaths true",
                    "git config core.autocrlf true",
                    "git config core.safecrlf false"
                };

                if (!string.IsNullOrWhiteSpace(AuthorName))
                {
                    commands.Add("git config user.name \"" + AuthorName + "\"");
                }

                if (!string.IsNullOrWhiteSpace(Email))
                {
                    commands.Add("git config user.email \"" + Email + "\"");
                }

                var exitCode = await ProcessHelper.RunCommandLineAsync(loggerService, RepoPath, commands.ToArray());
                return exitCode == 0;
            }
            catch (Exception ex)
            {
                loggerService.Error($"Error creating git repository: {ex.ToString()}");
            }
            return false;
        }

        #endregion Methods
    }
}
