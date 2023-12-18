# Unity Project Setup with GitHub Integration

This repository contains the setup guide for integrating a Unity project with GitHub, GameCI, and itch.io for continuous integration and deployment. The project follows the guidelines and templates outlined by the GameCI community documentation available [here](https://game.ci/docs/getting-started/).

## Infographic

Feel free to contribute by enhancing the documentation or providing additional steps as needed.
![How to integrate CICD in Unity game with Game CI and GitHub ](https://github.com/MDMSerra/UnityProjectWithCICD/assets/122322927/e50249ef-e9ae-4497-b7df-733f248b6553)

## Project Setup Steps
| Step                                 | Description                                                               |
|--------------------------------------|---------------------------------------------------------------------------|
| 1. Create Unity project              | Begin the project setup within Unity.                                     |
| 2. Set up GitHub remote repository with Unity's gitignore | Establish a remote GitHub repository and apply Unity's .gitignore file to it. |
| 3. Create local Git repository and pull from remote | Create a local Git repository and synchronize it with the remote one by pulling changes. |
| 4. Read GameCI development community documentation | Review the documentation provided by the GameCI development community.      |
| 5. Verify Unity editor version       | Ensure that the Unity editor version falls within the supported range by GameCI for utilizing Unity actions via Game-CI/docker. |
| 6. Activate Unity personal license   | Manually activate the Unity personal license as a one-time setup.          |
| 7. Generate itch.io API key          | Generate an API key from itch.io, which will be used for deploying the project. |
| 8. Set up itch.io project            | Configure the project on itch.io with the necessary settings for GitHub-based deployment. |
| 9. Configure GitHub action secrets   | Set up action secrets in GitHub containing variables such as UNITY_LICENSE, Unity email, Unity password, and the itch.io API key. |
| 10. Implement Unity Test Runner      | Create a workflow utilizing Unity Test Runner to manage and execute tests within Unity. |
| 11. Set up build and deployment workflow | Develop workflows for building the project and deploying it effectively. |
