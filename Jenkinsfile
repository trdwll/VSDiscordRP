
pipeline {
  agent {
    node {
      label 'Windows'
    }
  }
  
  stages {
    stage('Restore') {
      steps {
        bat "\"${tool 'MSBuild'}\" VSDiscordRP.csproj /t:Restore"
      }
    }

    stage('Build Release') {
      steps {
        bat "\"${tool 'MSBuild'}\" VSDiscordRP.csproj /p:Configuration=Release"
      }
    }

    stage('Build Debug') {
      steps {
        bat "\"${tool 'MSBuild'}\" VSDiscordRP.csproj /p:Configuration=Debug"
      }
    }
    
    stage('Publish') {
      when {
        branch "main"
      }
      steps {
        bat "C:\\JenkinsBuilder.exe VSDiscordRP Publish \"%WORKSPACE%\""
      }
    }
  }
}
