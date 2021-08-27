# datadog-playground

https://app.datadoghq.eu/signup/agent#docker

docker run -d --name dd-agent -v /var/run/docker.sock:/var/run/docker.sock:ro -v /proc/:/host/proc/:ro -v /sys/fs/cgroup/:/host/sys/fs/cgroup:ro -e DD_API_KEY=REPLACEME -e DD_SITE="datadoghq.eu" gcr.io/datadoghq/agent:7

https://app.datadoghq.eu/help/quick_start

net localgroup "Performance Monitor Users" "IIS APPPOOL\DefaultAppPool" /add